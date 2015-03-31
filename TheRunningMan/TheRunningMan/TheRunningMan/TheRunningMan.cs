using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Effects;
using Jypeli.Widgets;

public class TheRunningMan : PhysicsGame
{
    PlatformCharacter2 pelaaja;

    Image man = LoadImage("hahmo");
    Image este1 = LoadImage("este1");
    Image este2kuva = LoadImage("este2");
    Image este3kuva = LoadImage("este3");
    Image este4kuva = LoadImage("este4");
    Image este5kuva = LoadImage("este5");
    Image este6kuva = LoadImage("este6");


    public override void Begin()
    {
        LuoKentta();
        luoOhjaimet();
        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
    void LuoKentta()
    {
        ColorTileMap ruudut = ColorTileMap.FromLevelAsset("theRunningMan");
        ruudut.SetTileMethod(Color.Gray, LuoPelaaja);
        ruudut.SetTileMethod(Color.Black, LuoTaso);
        ruudut.SetTileMethod(Color.Blue, LuoEste1);
        ruudut.SetTileMethod(Color.Red, LuoEste2);
        ruudut.SetTileMethod(Color.Purple, LuoEste3);
        ruudut.SetTileMethod(Color.Yellow, LuoEste4);
        ruudut.SetTileMethod(Color.FromHexCode("B6FF00"), LuoEste5);
        ruudut.SetTileMethod(Color.FromHexCode("0026FF"), LuoEste6);
        ruudut.Execute(150, 150);
        Camera.Follow(pelaaja);
        Camera.ZoomToLevel();
    }

    void LuoPelaaja(Vector paikka, double leveys, double korkeus)
    {
        pelaaja = new PlatformCharacter2(leveys, korkeus);
        pelaaja.Position = paikka;
        pelaaja.Image = man;
        //AddCollisionHandler(pelaaja, TormaaTahteen);
        Add(pelaaja);
    }

    void LuoTaso(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject taso = PhysicsObject.CreateStaticObject(leveys, korkeus);
        taso.Position = paikka;
        //taso.Image = groundImage;
        taso.Color = Color.Blue;

        Add(taso);
    }
    void LuoEste1(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este = new PhysicsObject(leveys, korkeus);
        este.IgnoresCollisionResponse = true;
        este.Position = paikka;
        este.Image = este1;
        este.CollisionIgnoreGroup = 1;
        Add(este);

    }
    void LuoEste2(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este2 = new PhysicsObject(leveys, korkeus);
        este2.IgnoresCollisionResponse = true;
        este2.Position = paikka;
        este2.Image = este2kuva;
        este2.CollisionIgnoreGroup = 1;
        Add(este2);


    }
    void LuoEste3(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este3 = new PhysicsObject(leveys, korkeus);
        este3.IgnoresCollisionResponse = true;
        este3.Position = paikka;
        este3.Image = este3kuva;
        este3.CollisionIgnoreGroup = 1;
        Add(este3);


    }
    void LuoEste4(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este4 = new PhysicsObject(leveys, korkeus);
        este4.IgnoresCollisionResponse = true;
        este4.Position = paikka;
        este4.Image = este4kuva;
        este4.CollisionIgnoreGroup = 1;
        Add(este4);

    }
    void LuoEste5(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este5 = new PhysicsObject(leveys, korkeus);
        este5.IgnoresCollisionResponse = true;
        este5.Position = paikka;
        este5.Image = este5kuva;
        este5.CollisionIgnoreGroup = 1;
        Add(este5);
    }
    void LuoEste6(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este6 = new PhysicsObject(leveys, korkeus);
        este6.IgnoresCollisionResponse = true;
        este6.Position = paikka;
        este6.Image = este6kuva;
        este6.CollisionIgnoreGroup = 1;
        Add(este6);
    }
    void luoOhjaimet()
    {
 
        Keyboard.Listen(Key.Escape,ButtonState.Pressed,ConfirmExit, "Lopeta peli");

        Keyboard.Listen(Key.Left, ButtonState.Down,Liikuta, "Pelaaja liikkuu", Direction.Left);
        Keyboard.Listen(Key.Right, ButtonState.Down,Liikuta, "Pelaaja liikkuu", Direction.Right);
        Keyboard.Listen(Key.Up, ButtonState.Down,Hyppaa, "Pelaaja hyppaa", 400.0);


    }
    void Liikuta(Direction suunta)
    {
        pelaaja.Walk(suunta);
        if (pelaaja.X >= 10)
        {
            pelaaja.Stop();
            //pelaaja.StopWalking();
            pelaaja.X = 9;
        }
        if (pelaaja.X <= -10)
        {
            pelaaja.X = -9;
            pelaaja.Stop();
            //pelaaja.StopWalking();
        }
    }
    void Hyppaa(double korkeus)
    {
        pelaaja.Jump(korkeus);
    }
}
