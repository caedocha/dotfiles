" Pathogen Config
execute pathogen#infect()
syntax on
filetype plugin indent on

" GUI
colorscheme gruvbox
set background=dark
set guioptions-=m
set guioptions-=T
set guioptions-=r

" Custom
let mapleader=","
set number
set autoindent
set list
set listchars=tab:>\ ,trail:-,extends:>,precedes:<,nbsp:+
set history=1000
set autochdir
set hlsearch
set noswapfile

" Key Mappings
map <Leader>v :Vex <CR>
map <Leader>s :Sex <CR>
map <Leader>e :e. <CR>
map <Leader>q :q! <CR>
inoremap jj <ESC>

map <Left> <Nop>
map <Right> <Nop>
map <Up> <Nop>
map <Down> <Nop>

" Filetype Customs
autocmd Filetype html setlocal sw=2 expandtab ts=2
autocmd Filetype ruby setlocal sw=2 expandtab ts=2
autocmd Filetype python setlocal sw=2 noexpandtab ts=2
