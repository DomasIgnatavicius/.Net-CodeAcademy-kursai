
int a = 20;

tiesiogFunkcija(a); // nepakeis a reiksmes, nes perduodama tik data, reiskia po kapisonu yra sukuriamas naujas kintamasis, kuris yra 20, jis yra pamanipuliuojamas, taciau pats a nepakeiciamas
Console.WriteLine(a);

refFunkcija(ref a); // pakeis a reiksme, nes a yra perduodamas by reference, reiskiasi kad manipuliuosim paciu a. Siuo atveju galima isivaizduoti, kad funkcijos vidini kintamaji "kintamasis" mes tiesiog pakeiciam i a, juo pamanipuliuojam ir isspjaunam lauk. TUOTARPU jei nebutu ref mes pasiimtumem tik reiksme 20, taciau ne a ir nieko neispjautumem
Console.WriteLine(a);

outFunkcija(out a); // pakeis a reiksme, taciau informacijos dalinimasis yra tik vienpusis - outFunkcija gali tik siusti, taciua negali gauti info, nes kad ir koki kintamaji mes papassinsim, jis funkcijoje inicializuojamas kaip 0, todel informacijos srautas yra vienpusis. REF INFORMACIJOS SRAUTASS YRA DVIPUSIS. Taip pat out perduodama by reference, todel pakeiviama a reiksme
Console.WriteLine(a);


static void tiesiogFunkcija(int kintamasis)
{
    kintamasis += 10;
}

static void refFunkcija(ref int kintamasis)
{
    kintamasis += 10;
}

static void outFunkcija(out int kintamasis)
{
    kintamasis = 0;
    kintamasis += 10;
}
