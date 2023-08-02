local set = vim.opt

set.number = true
set.swapfile = false
set.autoindent = true
set.tabstop = 2
set.shiftwidth = 2
set.softtabstop = 2
set.expandtab = true
vim.g.mapleader = ","

return require("packer").startup(function()
  use 'wbthomason/packer.nvim'
  use 'ggandor/leap.nvim'
end)
