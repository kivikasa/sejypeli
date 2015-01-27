using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Effects;
using Jypeli.Widgets;

public class pong2 : PhysicsGame
{
    PhysicsObject pallo;

    public override void Begin()
    {
        LuoKentta(); 
        
        
        Vector impulssi = new Vector(500.0, 0.0);
        pallo.Hit(impulssi);
        
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");

        
        
    }
    void LuoKentta()
    {
         pallo = new PhysicsObject(40.0, 40.0);
        pallo.Shape = Shape.Circle;
        Add(pallo);
        pallo.X = -200.0;
        Vector impulssi = new Vector(500.0, 0.0);
        pallo.Hit(impulssi);
        Level.Background.Color = Color.Black;
        Camera.ZoomToLevel();
        Level.CreateBorders(1.0, false);
        pallo.Restitution = 1.0;
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
 
    }
}




