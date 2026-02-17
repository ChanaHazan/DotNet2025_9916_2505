

namespace DO;
[Serializable]
public class DalIdNotFoundException:Exception
{
    public DalIdNotFoundException(string messege) : base(messege) { }
}
[Serializable]
public class DalIdExistsException : Exception
{
    public DalIdExistsException(string messege) : base(messege) { }
}
[Serializable]
public class DalNotfoundObjectWithThisFilterException : Exception
{
    public DalNotfoundObjectWithThisFilterException(string messege) : base(messege) { }
}
public class FailedToDeleteFolder : Exception
{
    public FailedToDeleteFolder(string messege) : base(messege) { }
}


