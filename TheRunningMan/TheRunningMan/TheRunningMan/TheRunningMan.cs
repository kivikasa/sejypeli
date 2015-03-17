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
    
    public override void Begin()
    {
        // TODO: Kirjoita ohjelmakoodisi tähän

        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
    void LuoKentta()
    {
        ColorTileMap ruudut = ColorTileMap.FromLevelAsset("theRunningMan.png");
        ruudut.SetTileMethod(Color.Gray,  LuoPelaaja);
        ruudut.SetTileMethod(Color.Black,LuoTaso);
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
    pelaaja.Position =paikka;
    AddCollisionHandler(pelaaja, TormaaTahteen);
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
    void LuoEste1(Vector paikka, double leveys, double korkeus
} 

