alias m='cd ~/maya/2011-x64/scripts'
alias h='cd ~'
alias k='clear'
alias gs='git status'
alias gb='git branch'
alias ag='ack-grep'

GIT_PROMPT_ONLY_IN_REPO=1
source ~/.bash-git-prompt/gitprompt.sh
export PATH="$PATH:$HOME/.rvm/bin" # Add RVM to PATH for scripting
export PATH="$PATH:/usr/autodesk/maya/bin"
export PATH="$PATH:~/maya/2011-x64/scripts/sceneTasks/lib"
export PYTHONPATH="$PYTHONPATH:~/maya/2011-x64/scripts/sceneTasks"
export PYTHONPATH="$PYTHONPATH:~/maya/2011-x64/scripts/sceneTasks/lib"
