using System;

using R5T.T0132;


namespace R5T.T0210
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IProjectFileXmlText"/>
        public IProjectFileXmlText ToProjectFileXmlText(string value)
        {
            var output = new ProjectFileXmlText(value);
            return output;
        }

        /// <inheritdoc cref="IProjectFileXmlText"/>
        public IProjectFileXmlText ToProjectFileXmlText_WithTrim(string value)
        {
            var trimmedValue = value.Trim();

            var output = this.ToProjectFileXmlText(trimmedValue);
            return output;
        }
    }
}
