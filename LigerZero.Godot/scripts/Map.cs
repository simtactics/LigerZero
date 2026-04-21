public partial class Map : Control
{
	private bool _isMusicPlaying;

	private void MusicPlayer(bool isPlaying = true)
	{
		const string song = $"{LZConsts.TSO_DIR}/music/modes/map/tsomap2_v2.mp3";
		var soundtrack = GetNode<AudioStreamPlayer>("Soundtrack");

		if (!FileAccess.FileExists(song)) return;
		var mp3 = FileManager.LoadMP3(song);
		soundtrack.Stream = mp3;

		if (isPlaying) soundtrack.Play();
		else soundtrack.Stop();
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
