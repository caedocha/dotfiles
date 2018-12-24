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
Plugin 'vim-airline/vim-airline'
Plugin 'vim-airline/vim-airline-themes'
Plugin 'ctrlpvim/ctrlp.vim'
Plugin 'tpope/vim-rails'
Plugin 'tomtom/tcomment_vim'
Plugin 'vim-ruby/vim-ruby'
Plugin 'thoughtbot/vim-rspec'
Plugin 'mileszs/ack.vim'
Plugin 'morhetz/gruvbox'
Plugin 'tpope/vim-markdown'
Plugin 'vim-scripts/SyntaxRange'
Plugin 'vim-scripts/ingo-library'
Plugin 'elixir-editors/vim-elixir'
Plugin 'tpope/vim-surround'
Plugin 'ryanoasis/vim-devicons'

call vundle#end()

" Syntax Setup
syntax on
filetype plugin indent on

" GUI
colorscheme gruvbox
set background=dark

" Custom
let mapleader=","
let g:airline_theme="wombat"
let g:airline_powerline_fonts = 1
set encoding=UTF-8
set number
set autoindent
set list
set listchars=tab:>\ ,trail:-,extends:>,precedes:<,nbsp:+
set history=1000

" AUTOCHDIR
"set autochdir
"
autocmd BufEnter * silent! lcd %:p:h
set hlsearch
set noswapfile
set laststatus=2
set wildignore+=*/tmp/*,*.so,*.swp,*.zip
set incsearch
set splitbelow
"set splitright
set cuc cul
set modifiable
set wildmenu
set lazyredraw
set clipboard=unnamed
set buftype=

let g:ctrlp_custom_ignore = '\v[\/]\.(git|hg|svn)$'
" The Silver Searcher
if executable('ag')
  let g:ackprg = 'ag --vimgrep'
endif

" Key Mappings
map <Leader>v :Vex <CR>
map <Leader>s :Sex <CR>
map <Leader>e :e. <CR>
map <Leader>q :q! <CR>
map <Leader>w :set buftype= <CR><bar> :wa<CR> <bar> :echo "All buffers saved!"<CR>
map <Leader>p :call TogglePaste() <CR>
inoremap jj <ESC>
nnoremap <leader>cd :cd %:p:h<CR>:pwd<CR>

map <Left> <Nop>
map <Right> <Nop>
map <Up> <Nop>
map <Down> <Nop>

" Rspec.vim mappings
map <Leader>t :call RunCurrentSpecFile() <CR>
map <Leader>d :call RunNearestSpec() <CR>
map <Leader>l :call RunLastSpec() <CR>
map <Leader>a :call RunAllSpecs() <CR>
map <Leader>b :set buftype= <CR>

" Filetype Customs
autocmd Filetype html setlocal sw=2 expandtab ts=2
autocmd Filetype eruby setlocal sw=2 expandtab ts=2
autocmd Filetype ruby setlocal sw=2 expandtab ts=2
autocmd Filetype javascript setlocal sw=2 expandtab ts=2
autocmd Filetype python setlocal sw=2 noexpandtab ts=2

function! TogglePaste()
  if &paste == "nopaste"
    set paste
    echo 'PASTE SET'
  else
    set nopaste
    echo 'NO PASTE SET'
  endif
endfunction
