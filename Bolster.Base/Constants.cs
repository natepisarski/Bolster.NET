namespace Bolster.Base
{
    public static class Constants
    {
        public const string ReturnFromNoneTypeExceptionMessage = "Return invoked on none type";

        public const string TypeNotDeclaredLeftOrRightExceptionMessage =
            "Current instance is not listed as left or right. This means that the bug lies in the code subclassing Either " +
            "classes, or is indicitive of a bug within Bolster.";

        public const string ValueAsProvidesIncorrectType =
            "Value requested from Either instance cannot be created from the instance. This may mean that Return is " +
            "being called directly on the result of ValueAs";
    }
}