
var mylist = new MyList<int>();
mylist.Add(10);
mylist.Add(11);
mylist.Add(12);
mylist.Add(13);

foreach (var item in mylist)
{
    Console.WriteLine(item);
}

for (int i = 0; i < mylist.Count; i++)
{
    Console.WriteLine(mylist[i]);
}