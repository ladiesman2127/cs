#include "Game.h"

SDL_Texture* player_texture;
SDL_Rect* srcR, destR;

Game::Game()
= default;

Game::~Game()
= default;

void Game::init(const char* title, int x, int y, int width, int height, bool FullScreen)
{
	int flags = 0;
	if (FullScreen)
		flags = SDL_WINDOW_FULLSCREEN;
	if (SDL_Init(SDL_INIT_EVERYTHING) == 0)
	{
		std::cout << "Initialized...\n";
		window_ = SDL_CreateWindow(title, x, y, width, height, flags);
		if (window_)
		{
			std::cout << "Window created...\n";
		}

		renderer_ = SDL_CreateRenderer(window_, -1, flags);
		if (renderer_)
		{
			SDL_SetRenderDrawColor(renderer_, 255, 255, 255, 255);
			std::cout << "Renderer created...\n";
		}
		is_running_ = true;
	}
	else
	{
		is_running_ = false;
	}
	SDL_Surface* tmpSurface = IMG_Load("assets/player.png");
	player_texture = SDL_CreateTextureFromSurface(renderer_, tmpSurface);
	SDL_FreeSurface(tmpSurface);
}

void Game::handle_events()
{
	SDL_Event event;
	SDL_PollEvent(&event);
	switch (event.type)
	{
	case SDL_QUIT:
		is_running_ = false;
		break;
	default:
		break;

	}
}
int cnt = 0;;
void Game::update()
{
	destR.h = 72;
	destR.w = 72;
	destR.x = cnt;
	destR.y = cnt++;
}

void Game::render() const // ?
{
	SDL_RenderClear(renderer_);
	SDL_RenderCopy(renderer_, player_texture, NULL, &destR);
	SDL_RenderPresent(renderer_);
}

void Game::clean() const // ?
{
	SDL_DestroyWindow(window_);
	SDL_DestroyRenderer(renderer_);
	SDL_Quit();
	std::cout << "Game cleaned...\n";

}

