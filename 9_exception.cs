// Exception 

/* 
different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.

When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).
*/

// Try and Catch
/* The try statement allows you to define a block of code to be tested for errors while it is being executed.

The catch statement allows you to define a block of code to be executed, if an error occurs in the try block. */

using System;

namespace Exce{
    class Program{
        static void Main(string[] args){
            try{
                int[] myNum = {1, 3,5};
                Console.WriteLine(myNum[10]);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}

// Try and Catch

using System;

namespace Exce{
    class Program{
        static void Main(string[] args){
            try{
                int[] myNum = {1, 3,6};
                Console.WriteLine(myNum[10]);
            }
            catch (Exception e){
                Console.WriteLine("Something Went Wrong!");
            }
        }
    }
}

// Finally - The finally statement lets you execute code, after try...catch, regardless of the result

using System;

namespace Exce{
    class Program{
        static void Main(string[] args){
            try{
                int[] myNum = {1, 3,6};
                Console.WriteLine(myNum[1]);
            }
            catch (Exception e){
                Console.WriteLine("Something Went Wrong!");
            }
            finally{
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}

// The throw Keyword

/* The throw statement allows you to create a custom error.

The throw statement is used together with an exception class. 
There are many exception classes available in C#: ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc */

using System;

namespace Exce{
    class Program{
        static void checkAge(int Age){
            if(Age<18){
                throw new ArithmeticException(" access denied");
            }
            else{
                Console.WriteLine("Access Granted");
            }
        }
        static void Main(string[] args){
            checkAge(12);
        }
    }
}
