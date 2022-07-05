#pragma once
#ifndef _GAME_H_
#define _GAME_H_
#include <SDL.h>
#include "SDL_image.h"
#include <iostream>

class Game
{
public:
	Game();
	~Game();
	void init(const char* title, int x, int y, int width, int height, bool FullScreen);
	void handle_events();
	void update();
	void render() const;
	void clean() const;
	bool running() { return is_running_; }
private:
	bool is_running_{};
	SDL_Window* window_{};
	SDL_Renderer* renderer_{};
};
#endif /*_GAME_H_*/


