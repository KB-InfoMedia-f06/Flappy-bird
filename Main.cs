using Godot;
using System;

public partial class Main : Node
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public PackedScene PipeScene {get; set;}
	[Export]
	public PackedScene SootScene {get; set;}
	private Timer timer;
	public override void _Ready()
	{
		timer = GetNode<Timer>("PipeTime");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	public void OnTimeOut(){
		PipeObstacle Pipe = PipeScene.Instantiate<PipeObstacle>();
		Pipe.Position=GetNode<Marker2D>("PipeBuilder").Position;
		Random Height = new Random();
		
		Pipe.Position += new Vector2(0, Height.Next(-160,5));
		AddChild(Pipe);
		Random Time = new Random();
		timer.WaitTime = Time.Next(0,12)/4;
		
		
	}
	public void OnTimeOut2(){
		Soot cloud = SootScene.Instantiate<Soot>();
		cloud.Position=GetNode<Marker2D>("Chimney").Position;
		Random Height2 = new Random();
		
		cloud.Position += new Vector2(0, Height2.Next(-5,180));
		AddChild(cloud);
	}
	
}
