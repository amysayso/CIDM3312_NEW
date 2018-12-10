using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
            return View(await _context.Project.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .SingleOrDefaultAsync(m => m.ProjectID == id);

            if (project == null)
            {
                return NotFound();
            }

            var clients = 
                from participant in _context.Client
                join projectparticipant in _context.ProjectList
                on participant.ID equals projectparticipant.ProjectID
                where project.ID == projectparticipant.ProjectID
                select participant;

            var members = 
                from participant in _context.Member
                join projectparticipant in _context.ProjectList
                on participant.ID equals projectparticipant.ProjectID
                where project.ID == projectparticipant.ProjectID                
                select participant;

            ProjectDetailViewModel pdvm = new ProjectDetailViewModel
            {
                TheProject = project,
                ProjectClients = clients.ToList() ?? null,
                ProjectMembers = members.ToList() ?? null
            };


            return View(pdvm);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProjectName,ProjectDescription")] Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.SingleOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,ProjectName,ProjectDescription")] Project project)
        {
            if (id != project.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Projects/EditProjectParticipants/5
        public async Task<IActionResult> EditProjectParticipants(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.SingleOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }


            //var clients = await _context.Clients.ToListAsync();

            //CLIENTS
            //pull 'em into lists first
            var clients = await _context.Client.ToListAsync();
            var projectroster = await _context.ProjectList.ToListAsync();


            var uniqueclients = 
                from participant in clients
                join projectparticipant in projectroster
                on participant.ID equals projectparticipant.ProjectID
                where participant.ID != projectparticipant.ProjectID
                select participant;

            List<SelectListItem> clientsSelectList = new List<SelectListItem>();

            foreach(var client in clients)
            {
                clientsSelectList.Add(new SelectListItem { Value=client.ID, Text = client.FirstName + " " + client.LastName});
            }




            var membersOnProject = 
                from participant in _context.Member
                join projectparticipant in _context.ProjectList
                on participant.ID equals projectparticipant.ProjectID
                where project.ID == projectparticipant.ProjectID                
                select participant;

            var allMembers = 
                from participant in _context.Member           
                select participant;              

            var allMembersList = allMembers.ToList();
            var membersOnProjectList = membersOnProject.ToList();

            var membersNotOnProject = allMembersList.Except(membersOnProjectList).ToList();
            
            List<SelectListItem> membersSelectList = new List<SelectListItem>();

            foreach(var member in membersNotOnProject)
            {
                membersSelectList.Add(new SelectListItem { Value=member.ID, Text = member.FirstName + " " + member.LastName});
            }
            //create and prepare ViewModel
            ProjectDetailViewModel epdvm = new ProjectDetailViewModel
            {
                ProjID = project.ID,
                Project = project,
                Clients = ClientID,
                Members = SelectID
            };

            // SelectedDropDown SDD = new SelectedDropDown
            // {
            //     TheProject = project,
            //     ProjectClientsList = clientsSelectList,
            //     ProjectMembersList = membersSelectList
            // };
           
           
            return View(epdvm);
        }        
        // POST: Projects/EditProjectParticipants/5
        // [HttpPost, ActionName("EditProjectParticipants")]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> AddConfirmed(string id)
        // {
        //     // var participant = EditProjectParticipants.SelectListItem();--------------------------------------------------------------------
        //     //var participant = EditProjectDetailViewModel.ProjectMembersList;
            
        //     // var participant = EditProjectDetailViewModel.ProjectMembersList(m => m.ID == id);
        //     // _context.ProjectRoster.Add(participant);
        //     // await _context.SaveChangesAsync();
        //     // return RedirectToAction(nameof(Index));

        //     var participant = await _context.Members.SingleOrDefaultAsync(m => m.ID == id);
        //     _context.ProjectRoster.Add(participant);
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction(nameof(Index));
        // }


            // var participant = EditProjectParticipants.SelectListItem();--------------------------------------------------------------------
            //var participant = EditProjectDetailViewModel.ProjectMembersList;
            
            // var participant = EditProjectDetailViewModel.ProjectMembersList(m => m.ID == id);
            // _context.ProjectRoster.Add(participant);
            // await _context.SaveChangesAsync();
            // return RedirectToAction(nameof(Index));

//---------------------------------------------------------------------------------------------------------------------------------------


        // POST: Projects/EditProjectParticipants/5
        [HttpPost, ActionName("EditProjectParticipants")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddConfirmed(ProjectDetailViewModel EPDVMD)
        {
            var projectAddedTo = await _context.Project.SingleOrDefaultAsync(Pro => Pro.ProjectID == EPDVMD.ProjectID);
            var participantToAdd = await _context.Member.SingleOrDefaultAsync(Mem => Mem.ID == EPDVMD.SelectedID);
            var clientToAdd = await _context.Client.SingleOrDefaultAsync(Clen => Clen.ID == EPDVMD.SelectedID);


            ProjectList thing = new ProjectList
            {
                ProjectID = projectAddedTo.ID,
                Project = projectAddedTo,
                ProjectID = participantToAdd.ID,
                ProjectID = participantToAdd
            };

            //this writes a new record to the database
            await _context.ProjectList.AddAsync(thing);

            //this saves the  change from the write above
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


            //attempt to add client to project, failed. 
            //             ProjectRoster anotherThing = new ProjectRoster
            // {
            //     ProjectID = projectAddedTo.ID,
            //     Project = projectAddedTo,
            //     ProjectParticipantID = clientToAdd.ID,
            //     ProjectParticipant = clientToAdd
            // };

            // //this writes a new record to the database
            // await _context.ProjectRoster.AddAsync(anotherThing);

            // //this saves the  change from the write above
            // await _context.SaveChangesAsync();
            // return RedirectToAction(nameof(Index));
            
        }


//---------------------------------------------------------------------------------------------------------------------------------------

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .SingleOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
            
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var project = await _context.Project.SingleOrDefaultAsync(m => m.ID == id);
            _context.Project.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        private bool ProjectExists(string id)
        {
            return _context.Project.Any(e => e.ID == id);
        }
    }
}
//       //   POST: Projects/EditProjectParticipants/5
      
//          [HttpPost, ActionName("EditProjectParticipants")]
//          [ValidateAntiForgeryToken]

//          public async Task<IActionResult> AddConfirmed(EditProjectDetailViewModel model)
//          {
//         //  var participant = EditProjectParticipants.SelectListItem();
//         //  var participant = EditProjectDetailViewModel.ProjectMembersList;
            
//         //  var participant = EditProjectDetailViewModel.ProjectMembersList(m => m.ID == id);
//         //  _context.ProjectRoster.Add(participant);
//         //  await _context.SaveChangesAsync();
//         //  return RedirectToAction(nameof(Index));

//              var participant = await _context.Members.SingleOrDefaultAsync(m => m.ID == model.SelectedID);
//              _context.Members.Add(participant);
//              await _context.SaveChangesAsync();
//              return RedirectToAction(nameof(Index));

//             //  var client_ = await _context.Clients.SingleOrDefaultAsync(e => e.ID == model.SelectedID);
//             //  _context.Clients.Add(client_);
//             //  await _context.SaveChangesAsync();
//             //  return RedirectToAction(nameof(Index));      


//              }


//         // GET: Projects/Delete/5
//         public async Task<IActionResult> Delete(string id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }

//             var project = await _context.Projects
//                 .SingleOrDefaultAsync(m => m.ID == id);
//             if (project == null)
//             {
//                 return NotFound();
//             }

//             return View(project);
//         }

//         // POST: Projects/Delete/5
//         [HttpPost, ActionName("Delete")]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> DeleteConfirmed(string id)
//         {
//             var project = await _context.Projects.SingleOrDefaultAsync(m => m.ID == id);
//             _context.Projects.Remove(project);
//             await _context.SaveChangesAsync();
//             return RedirectToAction(nameof(Index));
//         }

//         private bool ProjectExists(string id)
//         {
//             return _context.Projects.Any(e => e.ID == id);
//         }
//     }
// }