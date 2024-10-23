using Godot;
using System;

public partial class PlayerBirb : CharacterBody2D
{
	// Called when the node enters the scene tree for the first time.
	
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();
	public override void _Ready()
	{
		GD.Print(gravity);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Vector2 mVelocity = Velocity;
		mVelocity.Y += gravity * (float)delta;
		
		
        if(Input.IsActionJustPressed("Jump")){
            mVelocity.Y=-500;
        }
        Velocity=mVelocity;
        MoveAndSlide();
		
	}
    public override void _Process(double delta)
    {
        
    }
	
	public void OnCollided(Area2D area2D)
	{
		GD.Print("I Am ded");
		RestartGame();
		QueueFree();
	}
	private void RestartGame()
    {
        GetTree().ReloadCurrentScene();
    }
}
