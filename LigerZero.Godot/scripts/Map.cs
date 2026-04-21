public partial class Map : Node3D
{
	public override void _Ready()
	{
		const string song = $"{LZConsts.TSO_DIR}/music/modes/map/tsomap2_v2.mp3";

		if (FileAccess.FileExists(song))
		{
			var mp3 = FileManager.LoadMP3(song);
			var soundtrack = GetNode<AudioStreamPlayer>("Soundtrack");
			soundtrack.Stream = mp3;
			soundtrack.Play();
		}

		base._Ready();
	}
}
