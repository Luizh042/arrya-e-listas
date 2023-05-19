#!/bin/bash
proj_name="Arraya_e_Lista"
proj_tests="${proj_name}.Tests"
cd "$proj_tests"
dotnet test
cd ..