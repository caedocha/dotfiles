echo 'SETTING GIT CONFIG...'
git config --global credential.useHttpPath true
echo 'FINISHED'

echo 'CREATING SYMLINKS:'
ln -s ~/dotfiles/vimrc ~/.vimrc
ln -s ~/dotfiles/bash_profile ~/.bash_profile
ln -s ~/dotfiles/zshrc ~/.zshrc
echo 'FINISHED'
