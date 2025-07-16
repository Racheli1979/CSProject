namespace DO;

//חריגה עבור מזהה שלא קיים
[Serializable]
public class DalExceptionIdDoesNotExistInTheList : Exception
{

    public DalExceptionIdDoesNotExistInTheList(string type)
    {

        throw new Exception($"ID does not exist in the list of {type}");
    }
}
//חריגה עבור ישות עם מספר מזהה שכבר קיים ברשימה
[Serializable]
public class DalExceptionIdIsAlreadyExistInTheList : Exception
{

    public DalExceptionIdIsAlreadyExistInTheList(string type)
    {
        throw new Exception($"ID is already exist in the list of {type}");
    }
}
//Nullחריגה עבור קבלת ישות

[Serializable]
public class DalExceptionNullReceived : Exception
{
    public DalExceptionNullReceived(string type)
    {
        throw new Exception($"null recived - {type}");
    }
}

// חריגה עבור תנאי שאין ערכים העונים על תנאי זה

[Serializable]
public class DalExceptionNoValuesByCondition : Exception
{
    public DalExceptionNoValuesByCondition(string type)
    {
        throw new Exception($"There are no values ​​that meet this condition.filter of- {type}");
    }
}