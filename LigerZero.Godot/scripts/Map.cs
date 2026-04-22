public partial class Map : Control
{
	private readonly string[] _mapMode =
	[
		$"{LZConsts.TSO_DIR}/music/modes/map/tsomap2_v2.mp3",
		$"{LZConsts.TSO_DIR}/music/modes/map/tsomap3.mp3",
		$"{LZConsts.TSO_DIR}/music/modes/map/tsomap4_v1.mp3"
	];

	private bool _isMusicPlaying;

	private void MusicPlayer(bool isPlaying = true)
	{
		if (!FileManager.TSOExists) return;

		const string song = $"{LZConsts.TSO_DIR}/music/modes/map/tsomap2_v2.mp3";
		var audio = GetNode<AudioStreamPlayer>("Soundtrack");

		audio.Stream = FileManager.LoadMP3(song);

		if (isPlaying) audio.Play();
		else audio.Stop();
	}

	public override void _Ready()
	{
		var musicBtn = GetNode<CheckButton>("SettingsDlg/SettingsCtn/MusicBtn");
		var settingsBtn = GetNode<Button>("MapPanel/SettingsCtn/SettingsBtn");

		settingsBtn.Pressed += OnSettingsButtonPressed;
		musicBtn.Toggled += OnMusicButtonPressed;
		MusicPlayer();
		base._Ready();
	}

	private void OnSettingsButtonPressed()
	{
		var settingsWin = GetNode<AcceptDialog>("SettingsDlg");
		settingsWin.Show();
	}

	private void OnMusicButtonPressed(bool ToggledOn)
	{
		if (ToggledOn) MusicPlayer();
		else MusicPlayer(false);
	}
}
