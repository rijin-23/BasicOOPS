class HighSchool : School
{
    public string SportsFieldName;
    public HighSchool(string name, string principal, int studentCount, string SportsFieldName) : base(name, principal, studentCount)
    {
        this.SportsFieldName = SportsFieldName;
    }

    public string getHSDetails(){
        return "Name: "+name+", Principal: "+principal+", StudentCount: "+studentCount+", SportsFieldName: "+SportsFieldName; 
    }
}