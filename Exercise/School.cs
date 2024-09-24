class School{
    public string name;
    public string principal;
    public int studentCount;

    public School(string name, string principal, int studentCount){
        this.name = name;
        this.principal = principal;
        this.studentCount = studentCount;
    }

    public string getDetails(){
        return "The name of the school is " + name + ". The name of the principal is "+ principal +". The student count is "+ studentCount;
    }
}