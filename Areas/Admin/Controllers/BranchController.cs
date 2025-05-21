using AutoMapper;
using CreditManagementSystemApp.Services.Interfaces;
using CreditManagementSystemApp.ViewModels.Branch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CreditManagementSystemApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;
        private readonly IMapper _mapper;
        private readonly IMerchantService _merchantService;

        public BranchController(IBranchService branchService, IMerchantService merchantService, IMapper mapper)
        {
            _branchService = branchService;
            _merchantService = merchantService;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var branches = await _branchService.GetAllAsync();
            if (branches is null)
                return NotFound();

            return View(branches);
        }

        public async Task<IActionResult> Create()
        {
            var merchants = await _merchantService.GetAllAsync();
            ViewBag.MerchantList = new SelectList(merchants, "Id", "Name");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BranchCreateVM createVM)
        {
            if (!ModelState.IsValid)
            {
                var merchants = await _merchantService.GetAllAsync();
                ViewBag.MerchantList = new SelectList(merchants, "Id", "Name");
                return View(createVM);
            }
            var result = await _branchService.AddAsync(createVM);
            if (result is null)
            {
                ModelState.AddModelError("", "Failed to create branch");
                var merchants = await _merchantService.GetAllAsync();
                ViewBag.MerchantList = new SelectList(merchants, "Id", "Name");
                return View(createVM);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var branch = await _branchService.GetByIdAsync(id);
            if (branch is null)
                return NotFound();

            var merchants = await _merchantService.GetAllAsync();
            ViewBag.MerchantList = new SelectList(merchants, "Id", "Name", branch.MerchantId);

            var editVM = _mapper.Map<BranchEditVM>(branch);
            return View(editVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BranchEditVM editVM)
        {
            if (!ModelState.IsValid)
            {
                var merchants = await _merchantService.GetAllAsync();
                ViewBag.MerchantList = new SelectList(merchants, "Id", "Name", editVM.MerchantId);
                return View(editVM);
            }
            var result = await _branchService.UpdateAsync(editVM);
            if (result is null)
            {
                ModelState.AddModelError("", "Failed to update branch");
                var merchants = await _merchantService.GetAllAsync();
                ViewBag.MerchantList = new SelectList(merchants, "Id", "Name", editVM.MerchantId);
                return View(editVM);
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            var branch = await _branchService.GetByIdAsync(id);
            if (branch is null)
                return NotFound();
            return View(branch);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var branch = await _branchService.GetByIdAsync(id);
            if (branch is null)
                return NotFound();
            return View(branch);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _branchService.DeleteAsync(id);
            if (!result)
            {
                ModelState.AddModelError("", "Failed to delete branch");
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
