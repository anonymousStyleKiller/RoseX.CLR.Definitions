namespace RoseX.CLR.Definitions.Enum;

public static class RoseXEnumerable
{
    /// <summary>
    /// This is method repair the standard GetEnumValues. Microsoft method is creating array and it is making allocation. 
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <returns></returns>
    public static TEnum[] GetEnumValues<TEnum>() where TEnum : struct
    {
        return (TEnum[])System.Enum.GetValues(typeof(TEnum));
    }
}