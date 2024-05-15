using DesafioPOO.Models;

Nokia nk = new Nokia("11963611244", "E63", "10851685456", 128);
Iphone ip = new Iphone("11975199687", "iPhone 11 Pro", "10185454015", 256);


Console.WriteLine("Nokia E63:");
nk.Ligar();
nk.InstalarAplicativo("Whatsapp");
nk.ReceberLigacao();

Console.WriteLine("iPhone:");
ip.Ligar();
ip.InstalarAplicativo("Telegram");
ip.ReceberLigacao();