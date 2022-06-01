// See https://aka.ms/new-console-template for more information
// var stranger = "Hanna";
string stranger = "Another";
int one = 1;
Console.WriteLine($"Hello, {stranger} {one}");

// Console.WriteLine("Hello, " + stranger);
// Console.WriteLine($"Hello, {stranger}");

Console.Write(stranger.IndexOf("n").ToString());

int a = 10, b = 20, c = 40;

int sum = a + b + c;


double div = sum / 3;


Console.WriteLine($"The Sum is {sum}");
Console.WriteLine($"what is {sum/3}");
// Console.WriteLine($"what is the maxish {maxIsh}");

int[] arr2 = new int[] {1,2,3,4};

var firstArr = new int[5] {-69, 46, 19, 2, 3};
firstArr[1] = 20;

for(var i = 0; i < firstArr.Length; i++) {
   Console.WriteLine($"The value at {i} is {firstArr[i]}"); 
};

foreach(var el in firstArr) {
    Console.WriteLine($"The value is {el}");
}

List<int> list = new List<int>();

list.AddRange(firstArr);
list.Add(1000);
list.Add(1001);
list.Add(1002);

foreach( var el in list) {
    Console.WriteLine($"The value is {el}");
}

