using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using SharpSvn;
using SharpSvn.Remote;
using SharpSvn.UI;

namespace SVNDiff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRemotePath.Text))
            {
                MessageBox.Show("必须输入远程目录", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtOutputPath.Text))
            {
                MessageBox.Show("必须输入文件输出目录", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Task.Run(() =>
            {
                List<ChangedFile> changedFiles = new List<ChangedFile>();
                var deleteList = new List<string>();
                var includeList = txtInclude.Text.Split(Environment.NewLine.ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);
                using (SvnRemoteSession remoteSession = new SvnRemoteSession(new Uri(txtRemotePath.Text)))
                {
                    SvnUI.Bind(remoteSession, new SvnUIBindArgs());
                    SvnRemoteLogArgs svnRemoteLogArgs = new SvnRemoteLogArgs();
                    var svnRemoteLocationSegmentEventArgsCollection =
                        new Collection<SvnRemoteLocationSegmentEventArgs>();
                    remoteSession.GetLocationSegments("/", out svnRemoteLocationSegmentEventArgsCollection);
                    foreach (var svnRemoteLocationSegmentEventArgse in svnRemoteLocationSegmentEventArgsCollection)
                    {
                        if (!long.TryParse(txtFirstRevision.Text, out var startRevision))
                        {
                            startRevision = 0;
                        }

                        startRevision =
                            svnRemoteLocationSegmentEventArgse.StartRevision > startRevision
                                ? svnRemoteLocationSegmentEventArgse.StartRevision
                                : startRevision;
                        if (!long.TryParse(txtSecondRevision.Text, out var endRevision))
                        {
                            endRevision = long.MaxValue;
                        }

                        endRevision = svnRemoteLocationSegmentEventArgse.EndRevision < endRevision
                            ? svnRemoteLocationSegmentEventArgse.EndRevision
                            : endRevision;
                        remoteSession.Log("/", new SvnRevisionRange(startRevision, endRevision), ((o, args) =>
                        {
                            foreach (var argsChangedPath in args.ChangedPaths)
                            {
                                if (cbDontIncludeDelete.Checked)
                                {
                                    if (argsChangedPath.Action == SvnChangeAction.Delete)
                                    {
                                        deleteList.Add(argsChangedPath.Path);
                                        changedFiles = changedFiles.Where(x => x.Path != argsChangedPath.Path).ToList();
                                        continue;
                                    }

                                    if (deleteList.Contains(argsChangedPath.Path))
                                    {
                                        continue;
                                    }
                                }

                                if (argsChangedPath.ContentModified == false)
                                {
                                    continue;
                                }

                                if (rbDontInclude.Checked && includeList.Any(x => argsChangedPath.Path.IndexOf(x) >= 0))
                                {
                                    continue;
                                }

                                if (rbInclude.Checked && !includeList.Any(x => argsChangedPath.Path.IndexOf(x) >= 0))
                                {
                                    continue;
                                }

                                ChangedFile changedFile = new ChangedFile();
                                changedFile.Path = argsChangedPath.Path;
                                changedFile.Author = args.Author;
                                changedFile.Message = args.LogMessage;
                                changedFile.FirstModifyAction = argsChangedPath.Action.ToString();
                                changedFile.FirstModifyRevision = args.Revision;
                                if (cbComparedEvery.Checked || !changedFiles.Contains(changedFile))
                                {
                                    changedFiles.Add(changedFile);
                                }
                            }
                        }));
                    }

                    //File.AppendAllLines("E:/123.txt", changedFiles.Select(x => $"文件信息：{x.Path}\t文件是否是修改:{x.FirstModifyAction}\t文件初次修改版本号:{x.FirstModifyRevision}\t初次修改作者:{x.Author}\t提交信息:{x.Message}"));
                    var wb = new XLWorkbook(new MemoryStream(Properties.Resources.model));
                    int lineNum = 1;
                    if (wb.TryGetWorksheet("ソース一覧", out IXLWorksheet iWorksheet))
                    {
                        foreach (var changedFile in changedFiles)
                        {
                            var row = iWorksheet.Row(lineNum + 2);
                            row.Cell("A").SetValue(lineNum);
                            row.Cell("B").SetValue(Path.GetDirectoryName(changedFile.Path));
                            row.Cell("C").SetValue(Path.GetFileName(changedFile.Path));
                            if (changedFile.FirstModifyAction == "Add")
                            {
                                row.Cell("H").SetValue("○");
                            }
                            else if (changedFile.FirstModifyAction == "Modify")
                            {
                                row.Cell("I").SetValue("○");
                            }

                            row.Cell("J").SetValue(changedFile.Author);
                            if (cbWriteFirstRevision.Checked)
                            {
                                row.Cell("L").Value = "版本号：" + changedFile.FirstModifyRevision;
                            }

                            if (cbWriteFirstAction.Checked)
                            {
                                row.Cell("L").Value += "执行操作" + changedFile.FirstModifyAction;
                            }

                            lineNum++;
                        }

                        var range = iWorksheet.Range(3, 1, lineNum + 1, 12);
                        range.Style.Border.BottomBorder = XLBorderStyleValues.Dotted;
                        range.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                        wb.SaveAs(txtOutputPath.Text);
                    }
                }

                this.Invoke((MethodInvoker) (() => 
                {
                    btnStart.Enabled = true;
                    btnStart.Text = "开始";
                }));
                MessageBox.Show("处理完成");
            });
            btnStart.Enabled = false;
            btnStart.Text = "处理中";
        }

        private void btnSelectOutPath_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = sfdSave.FileName;
            }
        }

        private void rbDontInclude_CheckedChanged(object sender, EventArgs e)
        {
            lbPath.Text = "不包含路径";
        }

        private void rbInclude_CheckedChanged(object sender, EventArgs e)
        {
            lbPath.Text = "包含路径";
        }
    }
}
