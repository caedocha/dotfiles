rm ~/.gvimrc
rm ~/.bashrc
rm ~/.zshrc
ln -s ~/dotfiles/gvimrc ~/.gvimrc
ln -s ~/dotfiles/bashrc ~/.bashrc
ln -s ~/dotfiles/zshrc ~/.zshrc
# OPENBOX
rm -R ~/.config/openbox
mkdir ~/.config/openbox
ln -s ~/dotfiles/openbox/autostart.sh ~/.config/openbox/autostart.sh
ln -s ~/dotfiles/openbox/rc.xml ~/.config/openbox/rc.xml
# TINT2
rm -R ~/.config/tint2
mkdir ~/.config/tint2
ln -s ~/dotfiles/tint2/tint2rc ~/.config/tint2/tint2rc
ln -s ~/dotfiles/tint2/tintwizard.conf ~/.config/tint2/tintwizard.conf
# VIM COLORSCHEME
rm ~/.vim/colors/gruvbox.vim
ln -s ~/dotfiles/vim/ ~/.vim/colors/gruvbox.vim
