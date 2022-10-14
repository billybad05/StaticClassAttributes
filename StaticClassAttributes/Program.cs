using StaticClassAttributes;

Console.WriteLine("StaticClassAttributes");

Song holiday = new Song("Holiday", "Green Day", 200);
Console.WriteLine(Song.songCount);
Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
Console.WriteLine(Song.songCount);

Console.WriteLine(kashmir.getSongCount());