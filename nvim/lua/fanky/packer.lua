vim.cmd [[packadd packer.nvim]]

return require('packer').startup(function(use)
  -- Packer can manage itself
  use 'wbthomason/packer.nvim'

  use {
    'nvim-telescope/telescope.nvim', tag = '0.1.8',
    -- or                            , branch = '0.1.x',
    requires = { {'nvim-lua/plenary.nvim'} }
  }

  use { "ellisonleao/gruvbox.nvim" }

  use("nvim-treesitter/nvim-treesitter", { run = ':TSUpdate'})

  use { "ThePrimeagen/harpoon" }

  use { "neovim/nvim-lspconfig" }

  use { "mason-org/mason.nvim" }

  use { "seblyng/roslyn.nvim" }

  -- DAP
  use 'mfussenegger/nvim-dap'
  use "igorlfs/nvim-dap-view"

end)
