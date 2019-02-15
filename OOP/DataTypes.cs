namespace OOP
{
    public class DataTypes
    {
        /* 
         * https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp
         * 
         * There are two kinds of types in C#: value types and reference types
        
         * value types:
            simple types, enum types, struct types, nullable value types
         
         * reference types:
            class types, interface types, array types, and delegate types

        - Value types
            Simple Types:
                Signed integral: sbyte, short, int, long
                Unsigned integral: byte, ushort, uint, ulong
                Unicode characters: char
                IEEE floating point: float, double
                High-precision decimal: decimal
                Boolean: bool

            Enum types:
                User-defined types of the form enum E {...}

            Struct types:
                User-defined types of the form struct S {...}

            Nullable value types:
                Extensions of all other value types with a null value
        
        - Reference types
            Class types:
                Ultimate base class of all other types: object
                Unicode strings: string
                User-defined types of the form class C {...}

            Interface types:
                User-defined types of the form interface I {...}

            Array types:
                Single- and multi-dimensional, for example, int[] and int[,]

            Delegate types:
                User-defined types of the form delegate int D(...)


         - Primative data
            - Texts
                - string
                - char

            - Numbers
                - Decimals
                    - float (4 bytes)
                    - double (8 bytes)
                    - decimal (16 bytes)

                - Integers
                    - byte (1 byte)
                    - short (2 byte)
                    - int (4 bytes)
                    - long (8 bytes)

         - User Defined data
            - enum
            - struct            

        int i = 123;
        object o = i;    // Boxing
        int j = (int)o;  // Unboxing

        Expressions:
            -Primary
                x.m: Member access
                x(...): Method and delegate invocation
                x[...]: Array and indexer access
                x++: Post-increment
                x--: Post-decrement
                new T(...):	Object and delegate creation
                new T(...){...}: Object creation with initializer
                new {...}: Anonymous object initializer
                new T[...]: Array creation
                typeof(T): Obtain Type object for T
                checked(x): Evaluate expression in checked context
                unchecked(x): Evaluate expression in unchecked context
                default(T): Obtain default value of type T
                delegate {...}: Anonymous function (anonymous method)

            - Unary
                +x: Identity
                -x: Negation
                !x: Logical negation
                ~x: Bitwise negation
                ++x: Pre-increment
                --x: Pre-decrement
                (T)x: Explicitly convert x to type T
                await x: Asynchronously wait for x to complete
            
            - Multiplicative
                x * y: Multiplication
                x / y: Division
                x % y: Remainder
            
            - Additive
                x + y: Addition, string concatenation, delegate combination
                x – y: Subtraction, delegate removal
            
            - Shift
                x << y: Shift left
                x >> y: Shift right
                - Relational and type testing
                x < y: Less than
                x > y: Greater than
                x <= y: Less than or equal
                x >= y: Greater than or equal
                x is T: Return true if x is a T, false otherwise
                x as T: Return x typed as T, or null if x is not a T
            
            - Equality
                x == y: Equal
                x != y: Not equal
            
            - Logical AND
                x & y: Integer bitwise AND, boolean logical AND
            
            - Logical XOR
                x ^ y: Integer bitwise XOR, boolean logical XOR
            
            - Logical OR
                x | y: Integer bitwise OR, boolean logical OR
            
            - Conditional AND
                x && y: Evaluates y only if x is not false
            
            - Conditional OR
                x || y: Evaluates y only if x is not true
            
            - Null coalescing
                x ?? y: Evaluates to y if x is null, to x otherwise
            
            - Conditional
                x ? y : z: Evaluates y if x is true, z if x is false
           
            - Assignment or anonymous function
                x = y: Assignment
                x op= y: Compound assignment; supported operators are
                *= /= %= += -= <<= >>= &= ^= |=
                (T x) => y: Anonymous function (lambda expression)

         */
    }
}
