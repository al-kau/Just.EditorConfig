using System.Globalization;

using Microsoft.Extensions.Logging;

namespace Just.EditorConfig.Analyzers
{
    // CA1700: Do not name enum values 'Reserved'
    // dotnet_diagnostic.CA1700.severity = none

    // Code with violations
    internal enum CA1700Violation
    {
        Value = 0,
        Reserved,
    }

    internal enum CA1700violation
    {
        value = 0,
        reserved,
    }

    // Fixed code
    internal enum CA1700Fixed
    {
        value = 0,
    }

    // CA1707: Identifiers should not contain underscores
    // dotnet_diagnostic.CA1707.severity = warning

    // Code with violations
    internal enum Enum_CA1707_Violation
    {
        Value_CA1707
    }

    internal class Class_CA1707_Violation
    {
        private const int _privateConstField = 0;
        public const int _publicConstField = 0;

        private readonly static int s_privateReadonlyStaticField = 1;
        public readonly static int s_publicReadonlyStaticField = 2;
        public int Value_CA1707 { get; set; }

        public int Increase()
        {
            return ++Value_CA1707 +
                s_privateReadonlyStaticField +
                s_publicReadonlyStaticField +
                _privateConstField +
                _publicConstField;
        }
    }

    // Fixed code
    internal enum EnumCA1707Fixed
    {
        ValueCA1707
    }

    internal class ClassCA1707Fixed
    {
        private const int PrivateConstField = 0;
        public const int PublicConstField = 0;

        private static int s_staticField;
        private readonly static int PrivateReadonlyStaticField = 1;
        public readonly static int PublicReadonlyStaticField = 2;

        private readonly int _readonlyField;
        private int _field;
        public int ValueCA1707 { get; set; }

        public ClassCA1707Fixed(int value)
        {
            _readonlyField = value;
        }

        public int Increase()
        {
            return ++s_staticField +
                ++_field +
                _readonlyField +
                ValueCA1707 +
                PrivateReadonlyStaticField +
                PrivateConstField +
                PublicConstField;
        }
    }

    // CA1708: Identifiers should differ by more than case
    // dotnet_diagnostic.CA1708.severity = warning

    // Code with violations
    internal class CA1708Violation
    {
        protected string someName = string.Empty;
        public string SomeName => someName;
    }

    // Fixed code
    internal class CA1708Fix
    {
        protected string _someName = string.Empty;
        public string SomeName => _someName;
    }

    // CA1710: Identifiers should have correct suffix
    // dotnet_diagnostic.CA1710.severity = warning

    // Code with violations
    internal class CA1710ViolationEvent : EventArgs
    { }

    public class CA1710ViolationExcep : Exception
    {
        public CA1710ViolationExcep()
        { }

        public CA1710ViolationExcep(string message) : base(message)
        { }

        public CA1710ViolationExcep(string message, Exception innerException) : base(message, innerException)
        { }
    }

    // Fixed code
    internal class CA1710FixedEventArgs : EventArgs
    { }

    public class CA1710FixedException : Exception
    {
        public CA1710FixedException()
        { }

        public CA1710FixedException(string message) : base(message)
        { }

        public CA1710FixedException(string message, Exception innerException) : base(message, innerException)
        { }
    }

    // CA1711: Identifiers should not have incorrect suffix
    // dotnet_diagnostic.CA1711.severity = warning

    // Code with violations
    internal abstract class CA1711ViolationQueue<T> : Stack<T>
    { }

    internal abstract class CA1711ViolationQueue<TKey, TValue> : Dictionary<TKey, TValue>
        where TKey : notnull
    { }

    internal enum CA1711ViolationEnum
    {
        None,
        Value
    }

    internal enum CA1711ViolationFlags
    {
        NoneFlag,
        FlagValue
    }

    internal enum CA1711ViolationFlag
    {
        NoneFlag,
        FlagValue
    }

    internal static class CA1711ViolationImpl
    {
        public delegate void OnMessageReceivedDelegate(string message);
    }

    internal static class CA1711ViolationEx
    {
    }

    // Fixed code
    internal abstract class CA1711FixedStack<T> : Stack<T>
    { }

    internal abstract class CA1711FixedDictionary<TKey, TValue> : Dictionary<TKey, TValue>
        where TKey : notnull
    { }
    internal static class CA1711Fixed
    {
        public delegate void OnMessageReceived(string message);
    }

    internal enum CA1711EnumFixed
    {
        None,
        Value,
        NoneFlag,
        FlagValue
    }

    // CA1712: Do not prefix enum values with type name
    // dotnet_diagnostic.CA1712.severity = warning

    // Code with violations
    internal enum CA1712Violation
    {
        CA1712ViolationBitmap = 0,
        CA1712ViolationGrayscale = 1,
        CA1712ViolationIndexed = 2,
        CA1712ViolationRGB = 3
    }

    // Fixed code
    internal enum CA1712Fixed
    {
        Bitmap = 0,
        Grayscale = 1,
        Indexed = 2,
        RGB = 3
    }

    // CA1713: Events should not have before or after prefix
    // dotnet_diagnostic.CA1713.severity = warning

    // Code with violations
    internal class CA1713Violation
    {
        public event EventHandler<EventArgs>? AfterProjectFileOpened;
        public event EventHandler<EventArgs>? BeforeProjectFileOpened;
    }

    // Fixed code
    internal class CA1713Fixed
    {
        public event EventHandler<EventArgs>? ProjectFileOpened;
    }

    // CA1714: Flags enums should have plural names
    // dotnet_diagnostic.CA1714.severity = warning

    // Code with violations
    [Flags]
    public enum CA1714ViolationType
    {
        None = 0,
        One = 1 << 0,
        Two = 1 << 1,
        Four = 1 << 2,
        Default = One | Two | Four,
    }

    // Fixed code
    [Flags]
    public enum CA1714FixedTypes
    {
        None = 0,
        One = 1 << 0,
        Two = 1 << 1,
        Four = 1 << 2,
        Default = One | Two | Four,
    }

    // CA1715: Identifiers should have correct prefix
    // dotnet_diagnostic.CA1715.severity = warning

    // Code with violations
    internal interface CA1715Violation
    {
        Value GetValue<Value>();
    }

    // Fixed code

    internal interface ICA1715Fixed
    {
        TValue GetValue<TValue>();
    }

    // CA1716: Identifiers should not match keywords
    // dotnet_diagnostic.CA1716.severity = warning

    // Code with violations
    internal interface ICA1716Violation
    {
        void Error();

        void Stop();

        void New();

        void Correct();
    }

    // Fixed code

    internal interface ICA1716Fixed
    {
        void Correct();
    }

    // CA1717: Only FlagsAttribute enums should have plural names
    // dotnet_diagnostic.CA1717.severity = warning

    // Code with violations
    public enum CA1717ViolationTypes
    {
        None = 0,
        One = 1,
        Two = 2,
        Four = 3,
    }

    // Fixed code
    public enum CA1717FixedType
    {
        None = 0,
        One = 1,
        Two = 2,
        Four = 3,
    }

    // CA1720: Identifiers should not contain type names
    // dotnet_diagnostic.CA1720.severity = warning

    // Code with violations
    internal class CA1720Violation
    {
        public uint Pointer { get; set; }
        public object? Object { get; set; }
        public static uint UInt32(uint i) { return ++i; }
        public bool Single { get; set; }
    }

    // Fixed code
    internal class CA1720Fixed
    {
        public uint CA1720Pointer { get; set; }
        public object? CA1720Object { get; set; }
        public static uint GetUInt32(uint i) { return ++i; }
        public bool IsSingle { get; set; }
    }

    // CA1721: Property names should not match get methods
    // dotnet_diagnostic.CA1721.severity = warning


    // Code with violations
    public class CA1721Violation
    {
        private static int s_value;

        public int Value
        {
            get
            {
                if (s_value is 0)
                {
                    s_value += 1;
                }

                return s_value;
            }
        }

        public string GetValue()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }

    // Fixed code
    public class CA1721Fixed
    {
        private int? _value;

        public int Value
        {
            get { return _value ??= 0; }
        }

        public string GetText()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }

    // CA1724: Type Names Should Not Match Namespaces
    // dotnet_diagnostic.CA1724.severity = warning

    // Code with violations
    public class Analyzers
    { }

    // Fixed code
    public class CA1724Fixed
    { }

    // CA1725: Parameter names should match base declaration
    // dotnet_diagnostic.CA1725.severity = warning

    internal interface ICA1725
    {
        void GetCA1725(object param);
    }

    // Code with violations
    public class CA1725Violation : ICA1725
    {
        public void GetCA1725(object obj)
        {
            throw new NotImplementedException();
        }
    }

    // Fixed code
    public class CA1725Fixed : ICA1725
    {
        public void GetCA1725(object param)
        {
            throw new NotImplementedException();
        }
    }

    // CA1727: Use PascalCase for named placeholders
    // dotnet_diagnostic.CA1727.severity = warning

    // Code with violations
    internal static class CA1727Violation
    {
        private static readonly Action<ILogger, int, Exception?> SomeLogAction = LoggerMessage.Define<int>(
            LogLevel.Information,
            new EventId(1, nameof(SomeLog)),
            "Log with placeholder {value}");

        internal static void SomeLog(this ILogger logger, int value)
        {
            SomeLogAction(logger, value, null);
        }
    }

    // Fixed code
    internal static class CA1727Fixed
    {
        private static readonly Action<ILogger, int, Exception?> SomeLogAction = LoggerMessage.Define<int>(
            LogLevel.Information,
            new EventId(1, nameof(SomeLog)),
            "Log with placeholder {Value}");

        internal static void SomeLog(this ILogger logger, int value)
        {
            SomeLogAction(logger, value, null);
        }
    }
}
