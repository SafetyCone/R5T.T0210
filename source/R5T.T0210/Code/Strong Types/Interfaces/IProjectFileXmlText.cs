using System;

using R5T.T0178;
using R5T.T0203;


namespace R5T.T0210
{
    /// <summary>
    /// Strongly-types a string as the XML content of a .NET project file.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectFileXmlText : IStrongTypeMarker,
        IXmlText
    {
    }
}