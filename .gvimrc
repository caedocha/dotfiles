" Pathogen Config
"execute pathogen#infect()
"syntax on
"filetype plugin indent on

" Vundle config
set nocompatible
filetype off
set rtp+=~/.vim/bundle/Vundle.vim
call vundle#begin()

" Vundle plugins
Plugin 'gmarik/Vundle.vim'
Plugin 'jelera/vim-javascript-syntax'
Plugin 'pangloss/vim-javascript'
Plugin 'nathanaelkane/vim-indent-guides'
Plugin 'bling/vim-airline'
Plugin 'kien/ctrlp.vim'

call vundle#end()
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
set laststatus=2
set wildignore+=*/tmp/*,*.so,*.swp,*.zip
set incsearch
let g:ctrlp_custom_ignore = '\v[\/]\.(git|hg|svn)$'

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
autocmd Filetype javascript setlocal sw=2 expandtab ts=2
autocmd Filetype python setlocal sw=2 noexpandtab ts=2
