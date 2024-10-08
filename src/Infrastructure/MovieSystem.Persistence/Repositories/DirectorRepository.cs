﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Application.IRepository;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Persistence.Repositories
{
    public class DirectorRepository : IRepository<Director>
    {
        private readonly MovieSystemContext _context;
        public DirectorRepository(MovieSystemContext context)
        {
            _context = context;
        }

        public void Create(Director entity)
        {
            _context.Directors.Add(entity);
            _context.SaveChanges();
        }

        public Director ReadByID(int id, bool loadNP)
        {
            IQueryable<Director> directors = _context.Directors;

            if (loadNP)
            {
                directors = directors
                    .Include(d => d.Name);
            }

            return directors.FirstOrDefault(x => x.DirectorID == id);
        }

        public List<Director> ReadAll(bool loadNP)
        {
            IQueryable<Director> directors = _context.Directors;

            if (loadNP)
            {
                directors = directors
                    .Include(d => d.Name);
            }

            return directors.ToList();
        }

        public void Update(Director entity)
        {
            Director directorFromRepository = ReadByID(entity.DirectorID, false);
            if (directorFromRepository != null)
            {
                directorFromRepository.Name = entity.Name;
                directorFromRepository.BirthDate = entity.BirthDate;
                directorFromRepository.Nationality = entity.Nationality;
            }
            else
            {
                throw new Exception("Director does not exist.");
            }
        }

        public void Delete(int id)
        {
            Director directorFromDb = ReadByID(id, false);
            if (directorFromDb != null)
            {
                _context.Directors.Remove(directorFromDb);
            }
            else
            {
                throw new Exception("User dows not exist.");
            }
        }
    }
}
