using Godot;
using System;
using System.Collections;

public partial class PipeObstacle : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += new Vector2(-300*(float)delta, 0);
	}
	public void LeftScreen(){
		QueueFree();
		GD.Print("Am gone");
	}
}