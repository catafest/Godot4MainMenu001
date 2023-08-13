using Godot;
using System;

public partial class menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	// 
	private void _on_options_pressed()
	{
		// Replace with function body.
		GD.Print("Option button");
		GetTree().ChangeSceneToFile("res://options.tscn");
	}
	//
	private void _on_exit_pressed()
	{
		// Replace with function body.
		GD.Print("Exit button");
		GetTree().Quit();
	}
	//
	private void _on_play_pressed()
	{
		// Replace with function body.
		GD.Print("Play button");
		GetTree().ChangeSceneToFile("res://play.tscn");
	}
	//
	private void _on_back_pressed()
	{
		// Replace with function body.
		GD.Print("Back button");
		GetTree().ChangeSceneToFile("res://menu.tscn");
	}
// top level closed
}
