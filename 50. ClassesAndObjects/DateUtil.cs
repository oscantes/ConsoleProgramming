//namespace _50._ClassesAndObjects; if we do this, DateUtil won't be known from other classes(files)

internal static class DateUtil
{
    public static int YearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }
    public static int Age(DateTime dateOfBirth)
    {
        if (dateOfBirth == null) //haklısın
            return 0;
        return DateTime.Now.Year - dateOfBirth.Year;
    }
}
