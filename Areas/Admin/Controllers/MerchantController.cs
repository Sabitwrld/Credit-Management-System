using AutoMapper;
using CreditManagementSystemApp.Models;
using CreditManagementSystemApp.Repositories.Interfaces;
using CreditManagementSystemApp.Services.Interfaces;
using CreditManagementSystemApp.ViewModels.Merchant;
using Microsoft.AspNetCore.Mvc;

namespace CreditManagementSystemApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MerchantController : Controller
    {
        private readonly IMerchantService _merchantService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public MerchantController(IMerchantService merchantService, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _merchantService = merchantService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var merchants = await _merchantService.GetAllAsync();
            return View(merchants);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MerchantCreateVM createVM)
        {
            if (!ModelState.IsValid)
                return View(createVM);
            var result = await _merchantService.AddAsync(createVM);
            if (result is null)
            {
                ModelState.AddModelError("", "Failed to create merchant");
                return View(createVM);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var merchant = await _merchantService.GetByIdAsync(id);
            if (merchant is null)
                return NotFound();

            var editVM = _mapper.Map<MerchantEditVM>(merchant);
            return View(editVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MerchantEditVM editVM)
        {
            if (!ModelState.IsValid)
                return View(editVM);
            var result = await _merchantService.UpdateAsync(editVM);
            if (result is null)
            {
                ModelState.AddModelError("", "Failed to update merchant");
                return View(editVM);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var merchant = await _merchantService.GetByIdAsync(id);
            if (merchant is null)
                return NotFound();
            return View(merchant);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var merchant = await _merchantService.GetByIdAsync(id);
            if (merchant is null)
                return NotFound();
            return View(merchant);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _merchantService.DeleteAsync(id);
            if (!result)
            {
                ModelState.AddModelError("", "Failed to delete merchant");
                return RedirectToAction(nameof(Index));
            }
            
            TempData["Success"] = "Merchant deleted successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}
