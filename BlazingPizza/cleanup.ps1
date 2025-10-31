# Remove duplicate files
Remove-Item -Path "Pages\Home.razor" -ErrorAction SilentlyContinue
Remove-Item -Path "Components\Pages\Home.razor" -ErrorAction SilentlyContinue
Remove-Item -Path "Components\App.razor" -ErrorAction SilentlyContinue
Remove-Item -Path "Components\Routes.razor" -ErrorAction SilentlyContinue

# Remove any other duplicate component files that might cause conflicts
Remove-Item -Path "Pages\Counter.razor" -ErrorAction SilentlyContinue
Remove-Item -Path "Pages\Weather.razor" -ErrorAction SilentlyContinue
