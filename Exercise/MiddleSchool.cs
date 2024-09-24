class MiddleSchool : School
{
    public decimal lowestGrade;
    public decimal highestGrade;
    public MiddleSchool(string name, string principal, int studentCount, decimal lowestGrade, decimal highestGrade) : base(name, principal, studentCount)
    {
        this.lowestGrade = lowestGrade;
        this.highestGrade = highestGrade;
    }

    public string getMSDetails(){
        return "Name: "+name+", Principal: "+principal+", StudentCount: "+studentCount+", LowestGrade: "+lowestGrade+", HighestGrade: "+highestGrade; 
    }
}