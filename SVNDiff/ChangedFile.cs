namespace SVNDiff
{
    public class ChangedFile
    {
        public string Path { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Author { get; set; }

        public string Message { get; set; }

        public string IsNew { get; set; }

        public long FirstModifyRevision { get; set; }

        public string FirstModifyAction { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ChangedFile changeFile)
            {
                return changeFile.Path == Path;
            }

            return obj.Equals(this);
        }

        public override int GetHashCode()
        {
            return Path.GetHashCode();
        }
    }
}