// See https://aka.ms/new-console-template for more information
using System;

var now=DateTime.Now;
var utcNow=DateTime.UtcNow;

var format="yyyy-M-d HH:MM";

Console.WriteLine("now:\t"+now.ToString(format));
Console.WriteLine("utcNow:\t"+utcNow.ToString(format));



var nowTick=now.Ticks/10000000;
Console.WriteLine("nowTick:\t"+nowTick);

var utcNowTick=utcNow.Ticks/10000000;
Console.WriteLine("utcNowTick:\t"+utcNowTick);


var utcStart=new DateTime(1970,1,1,0,0,0,DateTimeKind.Utc);
var utcStartTick=utcStart.Ticks/10000000;
Console.WriteLine("utcStartTick:\t"+utcStartTick);

utcStart=new DateTime(1970,1,1,0,0,0,DateTimeKind.Local);
utcStartTick=utcStart.Ticks/10000000;
Console.WriteLine("utcStartTick:\t"+utcStartTick);

utcStart=new DateTime(1970,1,1);
utcStartTick=utcStart.Ticks/10000000;
Console.WriteLine("utcStartTick:\t"+utcStartTick);



var nowZone=(nowTick-utcNowTick)/3600f;
Console.WriteLine("nowZone:\t"+nowZone);


var nowDistance=nowTick-utcStartTick;
Console.WriteLine("nowDistance:\t"+nowDistance);


var utcNowDistance=utcNowTick-utcStartTick;
Console.WriteLine("utcNowDistance:\t"+utcNowDistance);

Console.WriteLine("Hello, World!");
