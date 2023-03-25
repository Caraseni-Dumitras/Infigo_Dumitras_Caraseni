using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModels;
using CMSPlus.Domain.Models.TopicModels;
using CMSPlus.Presentation.CustomAttribute;
using CMSPlus.Services.Interfaces;
using CMSPlus.Services.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CMSPlus.Presentation.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentervice, IMapper mapper)
        {
            _commentService = commentervice;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Topic");
        }

        [HttpPost]
        [TypeFilter(typeof(CustomAuthorizationFilter))]
        [ActionName("Create")]
        public async Task<IActionResult> Create(TopicDetailsModel topic, string commentsJson)
        {
            var comments = JsonConvert.DeserializeObject<List<CommentModel>>(commentsJson);
            var systemName = new RouteValueDictionary(new { systemName = topic.SystemName });
            if (ModelState.IsValid)
            {
                topic.CommentCreateModel.TopicId = topic.Id;
                var commentCreate = topic.CommentCreateModel;
                var commentEntity = _mapper.Map<CommentCreateModel, CommentEntity>(commentCreate);
                await _commentService.Create(commentEntity);
                return RedirectToAction("Details", "Topic", systemName);
            }
            else
            {
                topic.Comments = comments;
                return View("~/Views/Topic/Details.cshtml", topic);
            }
        }
    }
}
