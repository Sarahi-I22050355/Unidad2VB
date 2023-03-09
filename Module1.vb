Imports Microsoft.VisualBasic.Logging 'Provides classes for creating and writing logs in Visual Basic applications.
Module Module1
    Sub Main()
        Dim start As Boolean = False
        Do
            ' We ask the user for the dog's data
            Console.Write("Enter the name of the dog: ")
            Dim name As String = Console.ReadLine()

            Console.Write("Enter the breed of the dog: ")
            Dim breed As String = Console.ReadLine()

            Console.Write("Enter the age of the dog: ")
            Dim age As Integer = Convert.ToInt32(Console.ReadLine())

            ' We create an object of the derived class (Dog)
            Dim myDog As New Dog()
            myDog.Name = name
            myDog.Age = age
            myDog.Breed = breed

            Console.WriteLine("My dog's name is {0}, he is of breed {1} and he is {2} years old.", myDog.Name, myDog.Breed, myDog.Age)
            myDog.Eat() ' We call the method of the base class
            myDog.Bark() ' We call the method of the derived class

            ' We create a list of objects of the derived class (Dog)
            Dim DogsList As New List(Of Dog)()
            DogsList.Add(myDog)
            Console.Write("Do you want to start the program again? (Y/N): ")
            Dim answer As String = Console.ReadLine()
            If answer.ToUpper() = "Y" Then
                start = True
                Console.Clear()
            Else
                start = False
                Console.WriteLine("Good Bye")
            End If
        Loop While start
        Console.ReadKey()
    End Sub
End Module
