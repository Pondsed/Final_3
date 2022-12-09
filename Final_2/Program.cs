using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string>LateFileList = new Queue<string>();
        while(true){
            Console.WriteLine("Please input your file name");
            Console.WriteLine("Or Type Exit To Finish ");
            Console.Write("Input : ");
            string Input_FileName = Console.ReadLine();
            if(Input_FileName == "Exit" ||Input_FileName == "exit" )
            {
                Console.WriteLine("---------------------- ");
                break;
            }
            else{
                if(LateFileList.GetLength() == 0){
                    LateFileList.Push(Input_FileName);
                }
                else if(LateFileList.GetLength() > 0){
                    int i = 0;
                    while(true){
                        if(Input_FileName == LateFileList.Get(i)){
                            break;
                        }
                        if(Input_FileName != LateFileList.Get(i)){
                            if(i == LateFileList.GetLength() - 1){
                            LateFileList.Push(Input_FileName);
                            if(LateFileList.GetLength() > 3){
                                LateFileList.Pop();
                            }
                            break;
                        }
                            i++;
                        }
                    }
                }
            }
        }
        Console.WriteLine("Your late File list");
        for(int i = 0; i<LateFileList.GetLength();i++){
            Console.WriteLine(LateFileList.Get(i));
        }
        
    }
}