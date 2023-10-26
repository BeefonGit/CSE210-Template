public class Assignment{
    private string _studentName;
    private string _topic;
    public void GetSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }
    public string GetStudentName() 
    {
        return _studentName;
    }
    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public string GetTopic() 
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

}