# SHORTCUTS

## GENERAL
alias h='cd ~'
alias k='clear'

## DEV
alias gs='git status'
alias gb='git branch'
alias ag='ack-grep'

## MAYA
alias m='cd ~/maya/2011-x64/scripts'

# ENV

## RVM & NVM
export NVM_DIR="$HOME/.nvm"
[[ -s "$HOME/.profile" ]] && source "$HOME/.profile" # Load the default .profile
[[ -s "$HOME/.rvm/scripts/rvm" ]] && source "$HOME/.rvm/scripts/rvm" # Load RVM into a shell session *as a function*

## MAYA
export PATH="$PATH:/usr/autodesk/maya/bin"
