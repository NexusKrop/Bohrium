namespace NexusKrop.Bohrium.Exception;
using System;

/// <summary>
/// The exception that is thrown when a <see langword="null"/> reference (<c>Nothing</c> in Visual Basic) is passed to the setter of
/// a property that does not accept it as a valid value.
/// </summary>
[Serializable]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S3925:\"ISerializable\" should be implemented correctly", Justification = "<Pending>")]
public class ValueNullException : Exception
{
    /// <summary>
    /// Initialises a new instance of the <see cref="ValueNullException"/> class.
    /// </summary>
    public ValueNullException() : base(ExceptionResources.NullValueException)
    {
    }

    /// <summary>
    /// Initialises a new instance of the <see cref="ValueNullException"/> class.
    /// </summary>
    /// <param name="message">The message.</param>
    public ValueNullException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initialises a new instance of the <see cref="ValueNullException"/> class.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="innerException">The inner exception.</param>
    public ValueNullException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
