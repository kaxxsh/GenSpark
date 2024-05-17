﻿using EmployeeRequestTrackerAPI.Models.DTOs;
using EmployeeRequestTrackerAPI.Models;

namespace EmployeeRequestTrackerAPI.Interfaces
{
    public interface IUserService
    {
        public Task<LoginReturnDTO> Login(UserLoginDTO loginDTO);
        public Task<EmployeeUserDTO> Register(EmployeeUserDTO employeeDTO);
        public Task<UserStatusDTO> ActivateUser(int EmployeeId);


    }
}
