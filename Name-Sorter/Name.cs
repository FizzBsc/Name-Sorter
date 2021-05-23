namespace Name_Sorter
{
    public class Name
    {
        public string givenNames { get; }
        public string lastName { get; }
        public Name(string givenNames, string lastName)
        {
            this.givenNames = givenNames;
            this.lastName = lastName;
        }

        public override string ToString() => $"{givenNames} {lastName}";

    }
}
