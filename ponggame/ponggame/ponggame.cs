using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace ponggame;
public class ponggame : Game;
private const int _WindowWidth = 750, _Windowheight= 500;
private const int _WindowWidth = 750, _Windowheight= 5450;
private GraphicsDeviceManager _graphics;
private SpriteBatch _spriteBatch;
private Texture2D _backgroundTexture, _ballTexture;

private Rectangle _playAreaBoundingBox;

private Vector2 _ballPosition, _ballDirection;

private float _ballSpeed;
public Game1()
{
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
}

protected override void Initialize()
{
    // TODO: Add your initialization logic here

    _graphics.PreferredBackBufferHeight = _WindowHeight;
    _graphics.ApplyChanges();
    _ballPosition = new Vector2(150, 195);
    _ballSpeed = 60;
    _ballDirection.X = -1;
    _ballDirection.Y = -1;

    base.Initialize();
}

protected override void LoadContent()
{
    _spriteBatch = new SpriteBatch(GraphicsDevice);

    // TODO: use this.Content to load your game content here

}

protected override void Update(GameTime gameTime)
{
    if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        Exit();

    // TODO: Add your update logic here

    base.Update(gameTime);
}

protected override void Draw(GameTime gameTime)
{
    GraphicsDevice.Clear(Color.CornflowerBlue);

    // TODO: Add your drawing code here
    _spriteBatch.Begin();

    _spriteBatch.Draw(_backgroundTexture, new Rectangle(0, 0, _WindowWidth, _Windowheight), Color.White);
    _spriteBatch.Draw(_ballTexture, _ballPosition, Color.White);
    
    _spriteBatch.End();

    base.Draw(gameTime);
}