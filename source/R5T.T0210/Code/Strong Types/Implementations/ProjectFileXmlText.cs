using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0210
{
    /// <inheritdoc cref="IProjectFileXmlText"/>
    [StrongTypeImplementationMarker]
    public class ProjectFileXmlText : TypedBase<string>, IStrongTypeMarker,
        IProjectFileXmlText
    {
        public ProjectFileXmlText(string value)
            : base(value)
        {
        }
    }
}