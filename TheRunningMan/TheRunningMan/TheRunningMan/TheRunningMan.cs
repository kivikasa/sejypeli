using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Effects;
using Jypeli.Widgets;

public class TheRunningMan : PhysicsGame
{
    PlatformCharacter pelaaja;
    Image hahmokuva = LoadImage("hahmo");
    

    public override void Begin()
    {
        // TODO: Kirjoita ohjelmakoodisi tähän

        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
    void LuoKentta()
    {
        ColorTileMap ruudut = ColorTileMap.FromLevelAsset("theRunningMan.png");
        ruudut.SetTileMethod(Color.Gray, LuoPelaaja);
        ruudut.SetTileMethod(Color.Black, LuoTaso);
        ruudut.SetTileMethod(Color.Blue, LuoEste1);
        ruudut.SetTileMethod(Color.Red, LuoEste2);
        ruudut.SetTileMethod(Color.Purple, LuoEste3);
        ruudut.SetTileMethod(Color.Yellow, LuoEste4);
        ruudut.SetTileMethod(Color.FromHexCode("B6FF00"), LuoEste5);
        ruudut.SetTileMethod(Color.FromHexCode("0026FF"), LuoEste6);
        ruudut.Execute(20, 20);

    }

    void LuoPelaaja(Vector paikka, double leveys, double korkeus)
    {
        pelaaja = new PlatformCharacter(10, 10);
        pelaaja.Position = paikka;
        pelaaja.Image = hahmokuva;
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
        PhysicsObject este = new PhysicsObject(5, 5);
        este.IgnoresCollisionResponse = true;
        este.Position = paikka;
        este.Image = Image  =
        este.CollisionIgnoreGroup = 1;
        Add(este);

    }
    void LuoEste2(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este2 = new PhysicsObject(5, 5);
        este2.IgnoresCollisionResponse = true;
        este2.Position = paikka;
        este2.Image = groundImage;
        este2.CollisionIgnoreGroup = 1;
        Add(este2);


    }
    void LuoEste3(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este3 = new PhysicsObject(5, 5);
        este3.IgnoresCollisionResponse = true;
        este3.Position = paikka;
        este3.Image = groundImage;
        este3.CollisionIgnoreGroup = 1;
        Add(este3);


    }
    void LuoEste4(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este4 = new PhysicsObject(5, 5);
        este4.IgnoresCollisionResponse = true;
        este4.Position = paikka;
        este4.Image = groundImage;
        este4.CollisionIgnoreGroup = 1;
        Add(este4);

    }
    void LuoEste5(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este5 = new PhysicsObject(5, 5);
        este5.IgnoresCollisionResponse = true;
        este5.Position = paikka;
        este5.Image = groundImage;
        este5.CollisionIgnoreGroup = 1;
        Add(este5);
    }
    void LuoEste6(Vector paikka, double leveys, double korkeus)
    {
        PhysicsObject este6 = new PhysicsObject(5, 5);
        este6.IgnoresCollisionResponse = true;
        este6.Position = paikka;
        este6.Image = groundImage;
        este6.CollisionIgnoreGroup = 1;
        Add(este6);
    }

}
