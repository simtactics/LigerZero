namespace LigerZero.Formats.tsodata;

public enum TSODataFieldClassification : byte
{
    SingleField,
    Map,
    TypedList
}

public enum TSOFieldMaskValues : byte
{
    None,
    Keep,
    Remove
}

public enum TSODataStringCategories
{
    None,
    Field,
    FirstLevel,
    SecondLevel,
    Derived,
    Unspecified
}