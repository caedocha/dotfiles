echo 'SETTING GIT CONFIG...'
git config --global credential.useHttpPath true
git config --global alias.develop 'checkout develop'
git config --global alias.swap 'checkout -'
echo 'FINISHED'

echo 'CREATING SYMLINKS:'
ln -s ~/dotfiles/vimrc ~/.vimrc
ln -s ~/dotfiles/bash_profile ~/.bash_profile
ln -s ~/dotfiles/zshrc ~/.zshrc
echo 'FINISHED'
