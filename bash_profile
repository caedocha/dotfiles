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

# RVM
export PATH="$PATH:$HOME/.rvm/bin" # Add RVM to PATH for scripting
[[ -s "$HOME/.profile" ]] && source "$HOME/.profile" # Load the default .profile
[[ -s "$HOME/.rvm/scripts/rvm" ]] && source "$HOME/.rvm/scripts/rvm" # Load RVM into a shell session *as a function*

# NVM
# export NVM_DIR="$HOME/.nvm"
# export NVM_DIR="/Users/carlos/.nvm"
# [ -s "$NVM_DIR/nvm.sh" ] && . "$NVM_DIR/nvm.sh"  # This loads nvm

## MAYA
export PATH="$PATH:/usr/autodesk/maya/bin"

# MYSQL

MYSQL="/usr/local/mysql/bin"
MYSQL_LIB="/usr/local/mysql/lib"
export PATH=$PATH:$MYSQL
export DYLD_LIBRARY_PATH=$MYSQL_LIB:$DYLD_LIBRARY_PATH

source ~/paths
