using System;


namespace R5T.T0210.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToProjectFileXmlText(string)"/>
        public static IProjectFileXmlText ToProjectFileXmlText(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectFileXmlText(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectFileXmlText(string)"/>
        public static IProjectFileXmlText ToProjectFileXmlText_WithTrim(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectFileXmlText_WithTrim(value);
        }
    }
}
